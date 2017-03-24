#Mariusz Bielecki#
from moduł_figura import Figura
kolo = Figura("kolo", 12, 8, 3)
kolo.narysuj()
kolo.przesun(2, 8)
print(kolo.zawiera(14,15))

kwadrat = Figura("kwadrat", 12, 8, 3)
kwadrat.narysuj()
kwadrat.przesun(2, 8)
print(kwadrat.zawiera(14,15))

punkt = Figura("punkt", 12, 8)
punkt.narysuj()
punkt.przesun(2, 8)
print(punkt.zawiera(14,15))
