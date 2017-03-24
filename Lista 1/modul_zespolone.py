#Mariusz Bielecki#

#Na liscie nie jest wyraznie napisane, że nie mogę używać klas, ale jakby co
#zamiana na funkcje przyjmujące listy jest trywialna


class Zespolone:
    def __init__(self, real, imaginary):
        self.r = real
        self.i = imaginary

    def __str__(self):
        if self.i < 0: return str(self.r)+" - "+str(self.i)[1:]+"i"
        return str(self.r)+" + "+str(self.i)+"i"

    def copy(self):
        return Zespolone(self.r, self.i)

    def __add__(self, other):
        real = self.r + other.r
        imaginary = self.i + other.i
        return Zespolone(real, imaginary)
    def add1(self, other):
        other.r += self.r
        other.i += self.i
        return None

    def __sub__(self, other):
        real = self.r - other.r
        imaginary = self.i - other.i
        return Zespolone(real, imaginary)
    def sub1(self, other):
        real = self.r - other.r
        imaginary = self.i - other.i
        other.r = real
        other.i = imaginary
        return None

    def __mul__(self, other):
        real = self.r * other.r - self.i * other.i
        imaginary = self.r * other.i + self.i * other.r
        return Zespolone(real, imaginary)
    def mult1(self, other):
        real = self.r * other.r - self.i * other.i
        imaginary = self.r * other.i + self.i * other.r
        other.r = real
        other.i = imaginary
        return None

    def __truediv__(self, other):
        real = ((self.r * other.r + self.i * other.i)
                /((other.r**2) * (other.i**2)))
        imaginary = ((self.i * other.r - self.r * other.i)
                     /((self.i**2) * (other.i**2)))

        return Zespolone(real, imaginary)

    def div1(self, other):
        real = ((self.r * other.r + self.i * other.i)
                /((self.i**2) * (other.i**2)))
        imaginary = ((self.i * other.r - self.r * other.i)
                     /((self.i**2) * (other.i**2)))

        other.r = real
        other.i = imaginary
        return None


def stworz(real, imaginary):
    return [real, imaginary]
def add(A, B):
    return [A[0]+B[0], A[1]+B[1]]
def add1(A, B):
    B[0], B[1]= [A[0]+B[0], A[1]+B[1]]
def __str__(self):
    if self[1] < 0: print(str(self[0])+" - "+str(self[1])[1:]+"i")
    else: print (str(self[0])+" + "+str(self[1])+"i")
