package Sql;
import java.sql.*;
import java.util.Properties;
import java.util.Scanner;
import java.util.UUID;

public class sqlIns {
    public static void main(String[] args) {
        Scanner pu = new Scanner(System.in);
        String str = pu.nextLine();
        UUID id1 = UUID.randomUUID(); // uuid key
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
        props.setProperty("user", "test");
        props.setProperty("password", "123");
        try {
            Connection conn = DriverManager.getConnection(url, props); // подключение к серверу
            PreparedStatement st = conn.prepareStatement("INSERT INTO clients VALUES (?,?)");
            st.setObject(1,id1);
            st.setString(2,str);
            st.executeUpdate();
            Statement st1 = conn.createStatement();
            ResultSet rs = st1.executeQuery("SELECT * FROM clients;");
            while (rs.next())
            {
                System.out.print("");
                System.out.println(rs.getString(1) + "," + rs.getString(2));
            }
            rs.close();
            st.close();
            st1.close();
            conn.close();
        }
        catch (SQLException s)
        {
            s.printStackTrace(); // вывод в консоль
            return;
        }
    }
}
