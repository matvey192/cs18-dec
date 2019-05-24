package Tasks;

import java.util.Scanner;
import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;
public class task1 {
    public static void main (String[] args)
    {
        DateTime current = new DateTime(); // текущее время
        DateTimeFormatter date = DateTimeFormat.forPattern("HH:mm d,M,y"); // задаем формат даты времени
        System.out.println(date.print(current));  // выводим отформатированную дату
        System.out.println(current);
        Scanner newdate = new Scanner(System.in); // Ввод через консоль
        String rouf = newdate.nextLine() ; // Прочитали строку
        DateTime crr= date.parseDateTime(rouf); // Строка  в дату
        if(crr.isAfter(current))
        {
            System.out.println("Current is past");
        }
        else if(current.isAfter(crr))
        {
            System.out.println("Crr is past");
        }
    }
}
