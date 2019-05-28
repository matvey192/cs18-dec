package io.github.matvey192.demo;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.util.Properties;
import java.util.Scanner;

@SpringBootApplication  // аннотация
public class DemoApplication {

	public static void main(String[] args) {
		try {
			Class.forName("org.postgresql.Driver"); // загрузка класса драйвер в виртуальную машину
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
			return ;
		}
		SpringApplication.run(DemoApplication.class, args);
	}
}
