package xmlrpcserver;

import java.io.IOException;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.server.XmlRpcServer;
import org.apache.xmlrpc.server.XmlRpcServerConfigImpl;
import org.apache.xmlrpc.webserver.WebServer;

public class Server {


    public static void main(String[] args) throws IOException, XmlRpcException {
        System.out.println("Starting server");
        WebServer server = new WebServer(8080);
        
        XmlRpcServer xmlServer = server.getXmlRpcServer();
        PropertyHandlerMapping phm = new PropertyHandlerMapping();
        phm.addHandler("Methods", Methods.class);
        xmlServer.setHandlerMapping(phm);
        
        XmlRpcServerConfigImpl config=(XmlRpcServerConfigImpl) xmlServer.getConfig();
        config.setEnabledForExceptions(true);
        config.setEnabledForExtensions(true);
        config.setContentLengthOptional(false);

        server.start();
        
        System.out.println("Server started successfully on port 8080");
        System.out.println("Awaiting requests");
    }
    
}
