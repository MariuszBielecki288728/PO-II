#Mariusz Bielecki#
from modul_zespolone import Zespolone

def test():
    z1 = Zespolone(-9, 97)
    z2 = Zespolone(27, -2)
    print("z1 =", z1)
    print("z2 =", z2)
    print('--------------------')
    print("z1 + z2 =", z1 + z2) #z1.__add__(z2)
    print("z1 - z2 =", z1 - z2) #z1.__sub__(z2)
    print("z1 / z2 =", z1 / z2) #z1.__truediv__(z2)
    print("z1 * z2 =", z1 * z2) #z1.__mul__(z2)

    print('--------------------')
    b = z2.copy()
    z1.add1(b)
    print("z1 + z2 =", b)

    b = z2.copy()
    z1.sub1(b)
    print("z1 - z2 =", b)

    b = z2.copy()
    z1.div1(b)
    print("z1 / z2 =", b)

    b = z2.copy()
    z1.mult1(b)
    print("z1 * z2 =", b)

test()
