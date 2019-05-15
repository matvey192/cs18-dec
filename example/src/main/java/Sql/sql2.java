package Sql;
import java.sql.*;
import java.util.Properties;
import java.util.Scanner;

public class sql2 {
    public static void main(String[] args)
    {
        Scanner pu = new Scanner(System.in);
        String str = pu.nextLine();

        try
        {
            Class.forName("org.postgresql.Driver"); // загрузка класса драйвер в виртуальную машину
        }
        catch (ClassNotFoundException e)
        {
            return;
        }
        String url = "jdbc:postgresql://localhost/business";
        Properties props = new Properties();
        props.setProperty("user","test");
        props.setProperty("password","123");
        try
        {
            Connection conn = DriverManager.getConnection(url, props);
            PreparedStatement st = conn.prepareStatement("SELECT lastname , firstname FROM employees WHERE gender = ?");
            st.setString(1,str);
            ResultSet rs = st.executeQuery();
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