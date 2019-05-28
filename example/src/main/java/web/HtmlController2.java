package web;

import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;

import java.io.*;
import java.net.URL;
import java.util.Scanner;

public class HtmlController2 implements HttpHandler {
    public static  final int Status_ok=200;
    @Override
    public  void  handle(HttpExchange sender) throws IOException {
        URL address = this.getClass().getClassLoader().getResource("Book1.txt"); //
        if(address==null)
        {
            // отправить браузеру заголовок 404
            // Завершить обработку
            return;
        }
        String filePath = address.getFile(); // Путь к файлу
        String out1;

        FileInputStream fstream = new FileInputStream(filePath);
        BufferedReader br = new BufferedReader(new InputStreamReader(fstream));

        StringBuilder sb = new StringBuilder();
        String strLine;
        while ((strLine = br.readLine()) != null)
        { // Пока не конец файла
             sb.append(strLine);
        }
        out1 = sb.toString();
        byte[] bs = out1.getBytes();
        sender.sendResponseHeaders(Status_ok,bs.length);
        OutputStream out = sender.getResponseBody();
        // Записываю размер строки в массив байтов//
        out.write(bs);
        out.close();
        fstream.close();
    }
}
