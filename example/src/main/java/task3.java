import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

import java.util.Scanner;
public class task3 {
    public static void main(String[] args)
    {
        DateTimeFormatter date = DateTimeFormat.forPattern("dd,MM,yyyy"); // задаем формат даты времени
        Scanner day = new Scanner(System.in);
        String kk = day.nextLine();
        DateTime crr1 = date.parseDateTime(kk);
        DateTimeFormatter date1 = DateTimeFormat.forPattern("EEEE");
        String ch= date1.print(crr1);
        System.out.println(ch);

    }  // Дано две даты надо посчитать кол-во воскресений вывести кол-во воскр
    //  Промышленный календарь создать его и считывать из него вводит 2 даты посчитать кол-во рабочих дней с учётом календаря
    // Даны 4(2интервала) даты нужно определеить. пересекаются они или нет, если да, то в какой момент.
}