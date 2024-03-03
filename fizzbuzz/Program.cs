class fizzBuzz(){
    public int lenghtFizz= 30;
    public void writeFizzBuzz(){
        for (int i = 1; i <= lenghtFizz; i++){
            if (i % 3 == 0 && i % 5 == 0){
                System.Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0){
                System.Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0){
                System.Console.WriteLine("Buzz");
            }
            else{
                System.Console.WriteLine(i);
            }
        }
    }
}
class Program{
    static void Main(string[] args){
        fizzBuzz fb = new fizzBuzz();
        fb.writeFizzBuzz();
    }
}