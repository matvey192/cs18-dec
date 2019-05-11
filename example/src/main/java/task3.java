import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

import java.util.Scanner;
public class task3
{
    public static void main(String[] args)
    {
        DateTimeFormatter date = DateTimeFormat.forPattern("dd,MM,yyyy"); // задаем формат даты времени
        Scanner day = new Scanner(System.in);
        String kk = day.nextLine();
        DateTime crr1 = date.parseDateTime(kk);
        DateTimeFormatter date1 = DateTimeFormat.forPattern("EEEE");
        String ch= date1.print(crr1);
        System.out.println(ch);

    }
}