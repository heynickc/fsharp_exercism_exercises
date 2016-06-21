namespace Exercism

module Triangle =

    type TriangleKind =
        | Equilateral
        | Isosceles
        | Scalene

    let kind len1 len2 len3 =
        TriangleKind.Equilateral
