namespace GestFormTest{
    public class Calculus{

        //This method will return a status value according to the different possible outcomes.
        //The status will be used by Main to display the result
        //Statuses:
        //0: Number is not divisible by 3 or 5
        //1: Number is dividable by 3 only
        //2: Number is dividable by 5 only
        //3: Number is dividable by 3 and 5
        public static int computeDivision(int number){
            int status = 0;

            if(number%3 == 0){
                status = 1;
            }
            if(number%5 == 0){
                status = (status==1?3:2);
            }
            return status;
        }
    }
}