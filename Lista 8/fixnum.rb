class Fixnum


  def czynniki
    i = 1
    czyn = Array.[]
    while i <= self
        if self % i == 0
          czyn << i
        end
        i += 1
    end
    return czyn
  end


  def ack(y)
    if self == 0
      return y + 1
    elsif y == 0
      (self-1).ack(1)
    else
      (self-1).ack(self.ack(y-1))
    end
  end

  def doskonala
    suma = 0
    pom = self-1
    while pom > 0
      if self % pom == 0
        suma += pom
      end
      pom = pom - 1
    end
    return suma == self
  end

  def slownie
    cyfry = ["zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć"]
    pom = self
    pomstr = String.new("")
    while pom !=0
      pomstr = cyfry[pom % 10] +" "+ pomstr
      pom = pom.div(10)
    end
    return pomstr
  end
end

for i in 2..30
  puts "#{i} #{i.doskonala}"
end
puts "ack(2, 1) #{2.ack(1)}"
puts 123.slownie
puts "#{6.czynniki}"
