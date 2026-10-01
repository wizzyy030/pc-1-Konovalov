string myName = "Александр Коновалов";
string groupName = "ИСП-254";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBudget = true;
 
Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");
 
// Комната
Console.WriteLine();
Console.WriteLine("Ремонт: комната");
 
double roomWidth = 3.5;
double roomLength = 4.2;
 
// Этот блок кода определяет площадь и периметр комнаты
double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;
 
Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");
 
// Ноутбук
Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");
 
int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;
 
// Этот блок кода считает итоговую цену с процентами и ежемесячный платёж
double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;
 
Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");
 
// Деление
Console.WriteLine();
Console.WriteLine("Внимание: деление int");
 
int totalStudents = 25;
int groupsCount = 4;
 
int studentsPerGroupWrong = totalStudents / groupsCount;
// Приводим к double, чтобы деление было дробным, а не целочисленным
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;
 
Console.WriteLine($"25 / 4 как int:    {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");
 
// Строки
Console.WriteLine();
Console.WriteLine("Способы собрать строку");
 
string firstName = "Александр";
string lastName = "Коновалов";
 
// Способ 1
string fullNameConcat = firstName + " " + lastName;
 
// Способ 2
string fullNameInterp = $"{firstName} {lastName}";
 
// Способ 3
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);
 
Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");
 
// Константы
Console.WriteLine();
Console.WriteLine("Константы");
 
const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ";
 
double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);
 
Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");
 
// Задание 1. Финансовый мини-расчёт
int scholarship = 4500;
int monthlyExpenses = 2500;
const int MonthsInSemester = 4;
 
Console.WriteLine($"Денег осталось к концу месяца: {scholarship - monthlyExpenses}");
Console.WriteLine($"За семестр останется: {(scholarship - monthlyExpenses) * MonthsInSemester}");
 
// Задание 3. Найди и исправь ошибку ★★★
Console.WriteLine();
int totalMinutes = 500;
int minutesPerLesson = 45;
int fullLessons = totalMinutes / minutesPerLesson;
int remainingMinutes = totalMinutes % minutesPerLesson;
Console.WriteLine($"{totalMinutes} минут = {fullLessons} полных занятий + {remainingMinutes} минут.");