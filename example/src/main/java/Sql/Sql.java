package Sql;
import java.sql.*;
import java.util.Properties;
import java.util.Scanner;

public class Sql {
    public static void main(String[] args)
    {
        try
        {
            Class.forName("org.postgresql.Driver"); // загрузка класса драйвер в виртуальную машину
        }
        catch (ClassNotFoundException e)
        {
            return;
        }
        String url = "jdbc:postgresql://localhost/business"; // адресс сервера
        Properties props = new Properties();
        props.setProperty("user","test"); // вход
        props.setProperty("password","123");
        try
        {
            Connection conn = DriverManager.getConnection(url, props);
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("SELECT lastname , firstname FROM employees WHERE gender = 'М'");
            while(rs.next())
            {
                System.out.print("");
                System.out.println(rs.getString(1)+","+rs.getString(2));
            }
            rs.close();
            st.close();
            conn.close();
        }
        catch (SQLException s)
        {
            s.printStackTrace(); // вывод в консоль
            return;
        }

    }
}
