import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;
import java.util.Scanner;
public class task4 {
    public static void main(String[] args) {
        DateTimeFormatter date = DateTimeFormat.forPattern("dd,MM,yyyy"); // задаем формат даты времени

        // считываем дату старта
        Scanner day = new Scanner(System.in);
        String s = day.nextLine();
        DateTime start = date.parseDateTime(s);

        // считываем дату конца
        Scanner day1 = new Scanner(System.in);
        String e = day1.nextLine();
        DateTime end = date.parseDateTime(e);

        //формат для получения названия дня недели
        DateTimeFormatter weekend = DateTimeFormat.forPattern("EEEE");

        String end1 = weekend.print(end); // день конца даты
        String start1 = weekend.print(start); // день начала даты

        // находим кол-во дней между датами
        Duration diff = new Duration(start, end);
        long dif = diff.getStandardDays();

        // вывод начала и старта + кол-во дней
        System.out.println(start1 + " " + end1);
        System.out.println(dif);

        //проверяем начало и конец
        String week = "воскресенье";
        boolean true_s = week.equals(start1);
        boolean true_e = week.equals(end1);

        int i = 0; // кол-во имеющихся воскресений
        long f = 0; // кол-во воскресений между датами

        // проверка начала и конца даты
        if(true_s == true&&true_e==true){
            i+=2;
        }
        else if (true_e==true){
            i+=1;
        }
        else if (true_s==true){
            i+=1;
        }
        f = (dif-i) / 7; // кол-во дней минус уже имющиеся воскресенья
        i += f; // ответ
        System.out.println("Кол-во воскресений между датами = "+i);
    }
    // Дано две даты надо посчитать кол-во воскресений вывести кол-во воскр
}
