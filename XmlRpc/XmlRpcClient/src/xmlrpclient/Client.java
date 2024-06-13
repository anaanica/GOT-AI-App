
package xmlrpclient;

import java.net.MalformedURLException;
import java.net.URL;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;

public class Client {

    public static void main(String[] args) throws MalformedURLException, XmlRpcException {
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL("http://localhost:8080"));

        XmlRpcClient client = new XmlRpcClient();
        client.setConfig(config);
        config.setEnabledForExtensions(true);

        if (args.length == 1) {
            Object[] params = new Object[]{args[0]};
            Double temperature = (Double) client.execute("Methods.getTemperatureByCity", params);
            String result = temperature == null ? "No data available" : args[0] + ": " + temperature.toString() + " degrees Celsius";
            System.out.println(result);
        } else {
            System.out.println("Please enter city");
        }
        
    }
    
}
