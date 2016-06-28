namespace Exercism

module BankAccount = 
    type BankAccount() = 
        let mutable (balance : float option) = None
        member b.Balance = balance
        member b.Open = balance <- Some(0.0)
        member b.Close = balance <- None
        member b.UpdateBalance amt = balance <- Some(balance.Value + amt)
    
    let mkBankAccount = BankAccount()
    let getBalance (b : BankAccount) = b.Balance
    let openAccount (b : BankAccount) = b.Open; b
    let closeAccount (b : BankAccount) = b.Close; b
    
    let updateBalance amt (b : BankAccount) = 
        b.UpdateBalance amt |> ignore
        b
