/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package xmlrpcserver.parsers.rss;

import xmlrpcserver.factory.UrlConnectionFactory;
import xmlrpcserver.factory.ParserFactory;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import javax.xml.stream.XMLEventReader;
import javax.xml.stream.XMLStreamConstants;
import javax.xml.stream.XMLStreamException;

import javax.xml.stream.events.Characters;
import javax.xml.stream.events.StartElement;
import javax.xml.stream.events.XMLEvent;
import xmlrpcserver.model.City;

/**
 *
 * @author ana
 */
public class CityParser {
    private static final String RSS_URL = "https://vrijeme.hr/hrvatska_n.xml";

    private CityParser() {
    }

    public static List<City> parse() throws IOException, XMLStreamException {
        List<City> cities = new ArrayList<>();
        HttpURLConnection con = UrlConnectionFactory.getHttpUrlConnection(RSS_URL);
        try (InputStream is = con.getInputStream()) {
            XMLEventReader reader = ParserFactory.createStaxParser(is);
            Optional<TagType> tagType = Optional.empty();
            City city = null;
            StartElement startElement = null;

            while (reader.hasNext()) {
                XMLEvent event = reader.nextEvent();
                switch (event.getEventType()) {
                    case XMLStreamConstants.START_ELEMENT:
                        startElement = event.asStartElement();
                        String qName = startElement.getName().getLocalPart();
                        tagType = TagType.from(qName);
                        break;
                    case XMLStreamConstants.CHARACTERS:
                        if (tagType.isPresent()) {
                            Characters characters = event.asCharacters();
                            String data = characters.getData().trim();
                            switch (tagType.get()) {
                                case CITY:
                                    city = new City();
                                    cities.add(city);
                                    break;

                                case CITY_NAME:
                                    if (city != null && !data.isEmpty()) {
                                        city.setName(data);
                                    }
                                    break;

                                case TEMP:
                                    if (city != null && !data.isEmpty()) {
                                        Double temperature = Double.parseDouble(data);
                                        city.setTemp(temperature);
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
        }
        return cities;
    }

    private enum TagType {

        CITY("Grad"),
        CITY_NAME("GradIme"),
        TEMP("Temp");

        private final String name;

        private TagType(String name) {
            this.name = name;
        }

        private static Optional<TagType> from(String name) {
            for (TagType value : values()) {
                if (value.name.equals(name)) {
                    return Optional.of(value);
                }
            }
            return Optional.empty();
        }
    }
}
