package LocalHost;
import com.sun.net.httpserver.HttpServer;
import web.CircleController;
import web.HtmlController;
import web.HtmlController2;
import web.controller;

import java.io.IOException;
import java.net.InetSocketAddress;

public class web1 {
    public static void main(String[] args) throws IOException {
        // номер сервера запущенного на пк
        InetSocketAddress socketAdress =new InetSocketAddress(8000);

        HttpServer hhtpServer = HttpServer.create(socketAdress,0); // Создание сервера с указанным портом
        hhtpServer.createContext("/test",new controller()); // если обращаются к серверу на указанную страницу
        hhtpServer.createContext("/circle",new CircleController()); // если обращаются к серверу на указанную страницу
        hhtpServer.createContext("/file",new HtmlController());
        hhtpServer.createContext("/file1", new HtmlController2());
        // обрабатываем классом контроллер

        hhtpServer.setExecutor(null);

        hhtpServer.start();
    }
}

