namespace Exercism

module BankAccount = 
    type BankAccount = 
        { balance : float option }
        member b.Open = { b with balance = Some(0.) }
        member b.Close = { b with balance = None }
        
        member b.UpdateBalance amt = 
            let newBalance = 
                match b.balance with
                | Some(x) -> x + amt
                | None -> amt
            { b with balance = Some(newBalance) }
        
    let mkBankAccount = { balance = None }
    let getBalance (b : BankAccount) = b.balance
    let openAccount (b : BankAccount) = b.Open
    let closeAccount (b : BankAccount) = b.Close
    let updateBalance amt (b : BankAccount) = b.UpdateBalance amt
