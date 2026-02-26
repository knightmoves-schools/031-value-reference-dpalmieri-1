namespace knightmoves;

public class Account {
    public static int OriginalTaxRate = 10;
    public static int[] CurrentLedger = {10, 20, 30, 40, 50};

    // Add your code here
    public int NewTaxRate = OriginalTaxRate;
    public int[] CopyLedger = CurrentLedger;
    
    public int UpdateLedger(correction){
        CurrentLedger[0] = correction;
        return CurrentLedger;
    }
    
    public int AdjustTaxRate(taxRate){
        NewTaxRate = taxRate;
        return NewTaxRate;
    }
}


