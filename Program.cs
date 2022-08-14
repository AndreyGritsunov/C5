Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999){

    Console.WriteLine("Вы ввели не правильное число!");    
} 
else{
     while (number >= 100){

            number /= 10;
    }
    Console.WriteLine(number % 10);

}
       

