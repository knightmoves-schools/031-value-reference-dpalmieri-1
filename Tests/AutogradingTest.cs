namespace Tests;

using System.Reflection;
using System.Text.RegularExpressions;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    private  string rootDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/../../../";

    [Fact]
    public void Should_Define_A_Public_Class_Level_Integer_Variable_Named_NewTaxRate_And_Set_It_To_OriginalTaxRate(){
      int newTaxRate = new Account().NewTaxRate;
      Assert.Equal(Account.OriginalTaxRate, newTaxRate);
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_Integer_Array_Variable_Named_CopyLedger_And_Set_It_To_CurrentLedger(){
      int[] copyLedger = new Account().CopyLedger;

      Assert.Same(Account.CurrentLedger, copyLedger);
    }

    [Fact]
    public void Should_Define_A_Public_ethod_Named_UpdateLedger_That_Takes_An_Integer_Called_Correction_And_Updates_The_First_Value_Of_The_CurrentLedger_With_This_New_Value_And_Returns_The_CurrentLedger(){
      Account account = new Account();
      account.UpdateLedger(100);

      Assert.Equal(100, Account.CurrentLedger[0]);
      Assert.Equal(100, account.CopyLedger[0]);
    }

    [Fact]
    public void Should_Define_A_Public_Method_Named_AdjustTaxRate_That_Takes_An_Integer_Called_TaxRate_And_Sets_The_NewTaxRate_To_The_TaxRate_That_Was_Passed_In_And_Returns_The_NewTaxRate(){
      Account account = new Account();
      account.AdjustTaxRate(50);

      Assert.Equal(10, Account.OriginalTaxRate);
      Assert.Equal(50, account.NewTaxRate);
    }
}