
//bad
int n = 0;
string s = "John";

// good
int studentCount = 100;
string studentName = "John";

class CostumerService() // PascalCase
{
    public const int MAX_CUSTOMER = 100; //ALL_CAPS
    public int CustumerCount { get; set; } // PascalCase

    private string lastCustomerName = "John"; // camelCase
    public string GetCustumerName(int customerId)// camelCase
    {
        string customerName = "John Doe";// camelcaseb
        return customerName;
    }
}