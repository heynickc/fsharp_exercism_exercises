module Exercism.Tests

open Exercism
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)

[<Test>]
let ``No name`` () =
    Assert.That(HelloWorld.hello None, Is.EqualTo("Hello, World!"))

[<Test>]
[<Ignore("Remove to run test")>]
let ``Sample name`` () =
    Assert.That(hello (Some "Alice"), Is.EqualTo("Hello, Alice!"))

[<Test>]
[<Ignore("Remove to run test")>]
let ``Other sample name`` () =
    Assert.That(hello (Some "Bob"), Is.EqualTo("Hello, Bob!"))