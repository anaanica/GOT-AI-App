/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package xmlrpcserver.model;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;

/**
 *
 * @author ana
 */
@XmlAccessorType(XmlAccessType.FIELD)
public class City {
    private String name;
    private Double temp;

    public City() {
    }
    
    public City(String name, Double temp) {
        this.name = name;
        this.temp = temp;
    }

    public String getName() {
        return name;
    }

    public Double getTemp() {
        return temp;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setTemp(Double temp) {
        this.temp = temp;
    }
}
