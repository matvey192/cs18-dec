import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

import java.util.Scanner;
public class task6 {
    public static void main(String[] args) {
        DateTimeFormatter work = DateTimeFormat.forPattern("dd,MM,yyyy");
        // Ввод
        Scanner date = new Scanner(System.in);
        String start1 = date.nextLine();
        DateTime start2 = work.parseDateTime(start1);

        // узнаем день месяца
        int days_s1 = start2.getDayOfMonth();
        int month_s1 = start2.getMonthOfYear();

        // Ввод
        Scanner date1 = new Scanner(System.in);
        String end1 = date1.nextLine();
        DateTime end2 = work.parseDateTime(end1);

        int days_e1 = end2.getDayOfMonth();
        int month_e1 = end2.getMonthOfYear();

        // Ввод
        Scanner date2 = new Scanner(System.in);
        String start3 = date2.nextLine();
        DateTime start4 = work.parseDateTime(start3);

        int days_s2 = start4.getDayOfMonth();
        int month_s2 = start4.getMonthOfYear();

        // Ввод
        Scanner date3 = new Scanner(System.in);
        String end3 = date3.nextLine();

        DateTime end4 = work.parseDateTime(end3);
        int st =0;
        int end =0;

        int days_e2 = end4.getDayOfMonth();
        int month_e2 = end4.getMonthOfYear();
        if (month_s1 == month_s2 || month_e1 == month_e2)
        {
            if(days_s1>days_s2&&days_s1<days_e2)
            {
                st = days_s1;
            }
            else if(days_s2>days_s1&&days_s2<days_e1)
            {
                st = days_s2;
            }

            if(days_e1>days_s1&&days_e1<days_e2)
            {
                end =days_e1;
            }
            else if (days_e2>days_s1&&days_e2<days_e1)
            {
                end = days_e2;
            }
        }
        System.out.println("День начала пересечения дат "+st+" День конца пересечения "+end);
    }
    // Даны 4(2интервала) даты нужно определеить. пересекаются они или нет, если да, то в какой момент.
    // Начало и конец, неправильный вывод
}
