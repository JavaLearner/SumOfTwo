namespace SumOfTwo
{
    internal class SumAlgorithm
    {
        

        public int firstOp { get; set; }
        public int secondOp { get; set; }

        public void calculateSum(int firstOp, int secondOp)
        {
            var newForm = new SumForm();
            newForm.viewResult(firstOp - secondOp , firstOp + secondOp);
        }
    }
}