package Tasks;

import java.util.Scanner;
import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

public class task2 {
    public  static  void main (String[] args)
    {
        DateTime current = new DateTime(); // текущее время
        DateTimeFormatter date = DateTimeFormat.forPattern("HH:mm d,M,y"); // задаем формат даты времени
        System.out.println(date.print(current));  // выводим отформатированную дату
        System.out.println(current);

        DateTime current1 = new DateTime();
        Scanner day = new Scanner(System.in);
        String kk = day.nextLine();
        DateTime crr1 = date.parseDateTime(kk);
        Duration ss = new Duration(crr1,current1); // Сравниваем даты
        System.out.println(ss.getStandardDays()); // Получаем разницу дни
        long hours = ss.getStandardHours();
        System.out.println(hours);
        hours = hours%24;
        System.out.println(hours);

    }
}
