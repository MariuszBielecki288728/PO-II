#Mariusz Bielecki#
class Figura:
    def __init__(self, typfig, x, y, a=None):
        self.typ = typfig
        self.x = x
        self.y = y
        if typfig == "kwadrat" or typfig == "kolo":
            self.a = a

    def narysuj(self):
        if self.typ == "punkt":
            print('rysuję punkt o współrzędnych', self.x, self.y)
        elif self.typ == "kwadrat":
            print('rysuję kwadrat o wierzchołkach o współrzędnych',
                    self.x, self.y, "|",
                    self.x + self.a, self.y, "|",
                    self.x, self.y + self.a, "|",
                    self.x + self.a, self.y + self.a,)
        elif self.typ == "kolo":
            print('rysuję koło o środku w x =', self.x,"y =", self.y,
                  'i promieniu', self.a)

    def przesun(self, x, y):
        self.x += x
        self.y += y

    def zawiera(self, x, y):
        if self.typ == "punkt":
            return (self.x == x) and (self.y == y)
        elif self.typ == "kwadrat":
            return ((self.x <= x <= (self.x + self.a)
                    and (self.y <= y <= (self.y + self.a))))
        elif self.typ == "kolo":
            return ((x - self.x)**2 + (y - self.y)**2)**(1/2) <= self.a
