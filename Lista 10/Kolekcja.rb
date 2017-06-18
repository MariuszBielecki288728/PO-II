class Elem
  attr_accessor :val, :next
  def initialize(v = nil)
    @val = v
  end
end



class Kolekcja
  def initialize
    @elem = Elem.new
  end

  def add(elem)
    x = @elem
    while x.next != nil
      x = x.next
    end
    x.next = Elem.new(elem)
  end

  def iteruj(i)
    x = @elem
    if x.next == nil
      raise "index out of range"
      return
    end
    while i>0
      x = x.next
      if x.next == nil
        throw "index out of range"
        return
      end
      i-=1
    end
    return x
  end

  def drukuj
    x = @elem
    while x.next != nil
      puts "#{x.next.val}"
      x = x.next
    end
  end

  def swap(i, j)
    x = self.iteruj(i)
    y = self.iteruj(j)
    pom = x.next.val
    x.next.val = y.next.val
    y.next.val = pom
  end

  def length
    x = @elem
    i=0
    while x.next != nil
      x = x.next
      i+=1
    end
    return i
  end

  def get(i)
      x = self.iteruj(i)
      return x.next.val
  end
end

class Sortowanie
  class << self

    def selsort(kol)
      for i in 0..kol.length-1
        mini = kol.get(i)
        minit = i
        for j in i..kol.length-1
          if kol.get(j)<mini
            mini = kol.get(j)
            minit = j
          end
        end
        if i!=j
          kol.swap(i, minit)
        end
      end
    end

    def bubsort(kol)
      for i in 0..kol.length-1
        for j in 0..kol.length-2-i
          if kol.get(j+1)<kol.get(j)
            kol.swap(j+1, j)
          end
        end
      end
    end



  end
end


lista = Kolekcja.new

lista.add(1)
lista.add(3)
lista.add(12)
lista.add(-2)
lista.add(-5)
#lista.swap(1,4)
#lista.drukuj

#Sortowanie.bubsort(lista)

Sortowanie.selsort(lista)
lista.drukuj
