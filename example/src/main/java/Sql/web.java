package Sql;
import Sql.circle.CircleController;
import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpServer;

import java.io.IOException;
import java.net.InetSocketAddress;

public class web {
    public static void main(String[] args) throws IOException {
        // номер сервера запущенного на пк
        InetSocketAddress socketAdress =new InetSocketAddress(8000);

        HttpServer hhtpServer = HttpServer.create(socketAdress,0); // Создание сервера с указанным портом
        hhtpServer.createContext("/test",new controller()); // если обращаются к серверу на указанную страницу
        hhtpServer.createContext("/circle",new CircleController()); // если обращаются к серверу на указанную страницу
        hhtpServer.createContext("/file",new HtmlController());
        // обрабатываем классом контроллер

        hhtpServer.setExecutor(null);

        hhtpServer.start();
    }
}

