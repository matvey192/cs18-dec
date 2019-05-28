package io.github.matvey192.demo;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

import java.sql.*;
import java.util.Properties;
import java.util.Scanner;

@Controller
public class MyController {
    @GetMapping("/test")
    public String handle(Model model)
    {
        model.addAttribute("name" , "It works!");
        return "index";
    }
    @RequestMapping("/circle")
    @ResponseBody // метод возваращает готовый результат
    public String gen(){
         return  "<!DOCTYPE html>\n" +
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
    }

    @GetMapping("/employees")
    public String Sql(
            @RequestParam(name ="id", required = false , defaultValue = "000") // Параметры запроса
            String emId,
            Model model
    ) {
        String names="";
        String url = "jdbc:postgresql://localhost/business";
        Properties props = new Properties();
        props.setProperty("user", "test");
        props.setProperty("password", "123");
        try {
            Connection conn = DriverManager.getConnection(url, props);
            PreparedStatement st = conn.prepareStatement("SELECT lastname , firstname FROM employees ");
            ResultSet rs = st.executeQuery();
            StringBuilder rp =new StringBuilder();
            while (rs.next()) {
                rp.append(rs.getString(1)+rs.getString(2));
            }
            model.addAttribute("name", rp.toString()+"/n");
            rs.close();
            st.close();
            conn.close();
            return "index";
        } catch (SQLException s) {
            s.printStackTrace(); // вывод в консоль
            return "Error";
        }
    }
}
