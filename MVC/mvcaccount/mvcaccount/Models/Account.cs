namespace mvcaccount.Models
{
    public class Account
    {
        public int Accountno { get; set; }
        public int amount { get; set; }

        public transtype gettranstype { set; get; }
    }
    public enum transtype
    {
        deposit, withdrawl
    }
}
