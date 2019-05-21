package Sql;

import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;

import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.URL;
import java.util.Scanner;

public class HtmlController implements HttpHandler {
    public static  final int Status_ok=200;
    @Override
    public  void  handle(HttpExchange sender) throws IOException {
        URL address = this.getClass().getClassLoader().getResource("index.html"); //
        if(address==null)
        {
            // отправить браузеру заголовок 404
            // Завершить обработку
            return;
        }
        String filePath = address.getFile(); // Путь к файлу
        File file = new File(filePath); //
        long size = file.getTotalSpace(); // находим размер файла
        String out1 = "";

        // StringBuilder sb = new StringBuilder();
        // sb.append("0");
        // sb.append("qwert");
        // t = sb.toString(); // Сделать 2-й контроллер с помощью StringBuilder / Сравнить время открытия маленького файла html и большого() книга
        Scanner s = new Scanner(file);
        while (s.hasNext()) { // Пока не конец файла
            // читаем построчно до конца
            // каждую строку преобразуем в массив байтов
            // отправялем массив байтов браузер
            out1 = out1+s.nextLine(); // Считываю строчки
        }
        byte[] bs = out1.getBytes();
        sender.sendResponseHeaders(Status_ok,bs.length);
        OutputStream out = sender.getResponseBody();
         // Записываю размер строки в массив байтов//
        out.write(bs);
        out.close();
    }
}
