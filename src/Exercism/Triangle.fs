namespace Exercism

module Triangle =

    type TriangleKind =
        | Equilateral
        | Isosceles
        | Scalene

    let kind (l1:decimal) (l2:decimal) (l3:decimal) =
        if (l1 + l2 <= l3) || (l2 + l3 <= l1) || (l1 + l3 <= l2) || (l1 = 0m && l2 = 0m && l3 = 0m) then
            raise (System.InvalidOperationException ("Illegal triangle"))
        elif l1 = l2 && l2 = l3 && l1 = l3 then
            TriangleKind.Equilateral
        elif l1 = l2 || l1 = l3 || l2 = l3 then
            TriangleKind.Isosceles
        else TriangleKind.Scalene
