/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package xmlrpcserver;

import java.io.IOException;
import java.util.List;
import javax.xml.stream.XMLStreamException;
import xmlrpcserver.model.City;
import xmlrpcserver.parsers.rss.CityParser;

/**
 *
 * @author Programer10
 */
public class Methods {
    public Double getTemperatureByCity(String name) throws IOException, XMLStreamException {
        Double temp = null;
        List<City> cities = CityParser.parse();
        for (City city : cities) {
            if (name.equals(city.getName())) {
                temp = city.getTemp();
            }
        }
        return temp;
    }
    
}
