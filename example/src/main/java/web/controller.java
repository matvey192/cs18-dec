package web;

import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;

import java.io.IOException;
import java.io.OutputStream;

public class controller implements HttpHandler
{
    public static  final int Status_ok=200;
    @Override
    public void handle (HttpExchange httpExchange) throws IOException {
        String st ="It works";

        httpExchange.sendResponseHeaders(Status_ok,st.length()); // Сообщаем браузеры что запрос обработан

        // открываем файл который будет отправлен в  браузер
        OutputStream os = httpExchange.getResponseBody();
        // рпеобразуем стровку в массив байтов
        os.write(st.getBytes());
        String circle = "<!DOCTYPE html>\n" +
                "<html>\n" +
                "<head>\n" +
                "<meta charset=\"utf-8\"/>\n" +
                "<head/>\n" +
                "<body>\n" +
                "<h1>Мой первый векторный рисунок</h1>\n" +
                "\n" +
                "<svg width=\"800\" height=\"600\">\n" +
                "\t<circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"green\" stroke-width=\"4\" fill=\"yellow\" />\n" +
                "</svg>\n" +
                "</body>\n" +
                "</html>";
        OutputStream pr = httpExchange.getResponseBody();
        pr.write(circle.getBytes());
        // Сообщаем о конце загрузки, закрываем файл
        os.close();
    }
}
