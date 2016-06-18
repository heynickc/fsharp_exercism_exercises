module Exercism.HelloWorldTests

open Exercism
open NUnit.Framework

[<Test>]
let ``No name`` () =
    Assert.That(HelloWorld.hello None, Is.EqualTo("Hello, World!"))

[<Test>]
let ``Sample name`` () =
    Assert.That(HelloWorld.hello (Some "Alice"), Is.EqualTo("Hello, Alice!"))

[<Test>]
let ``Other sample name`` () =
    Assert.That(HelloWorld.hello (Some "Bob"), Is.EqualTo("Hello, Bob!"))