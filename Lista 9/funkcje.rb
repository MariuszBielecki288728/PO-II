class Funkcja
  def initialize(&block)
    @f = block
  end

  def value(x)
    @f.call(x)
  end

  def zerowe(x, y, c)
    a, b = x, y
    wa, wb = @f.call(a), @f.call(b)
    epsilon = 2**(-32)

    if wa*wb > 0
      return nil
    end

    while (b-a).abs > c
      x =(a+b).fdiv(2)
      ws = @f.call(x)
      if ws.abs < epsilon
        break
      end
      if wa*ws < 0
        b = x
      else
        a = x
      end
    end
    return x
  end


  def pole(a, b)
    s = 0
    n = ((b-a).abs*1000).to_int
    dx = (b-a).fdiv(n)
    for i in 1..n do
      s += @f.call(a+i*dx)
    end
    s = s*dx
    return s
  end

  def poch(x)
    epsilon = 2**(-32)
    return (@f.call(x+epsilon)-@f.call(x-epsilon)).fdiv(2*epsilon)
  end

end


puts "#{Funkcja.new{|x| x**3*(x + Math.sin(x**2-1) - 1) - 1}.zerowe(1, 2, 0.0001)}"
puts "#{Funkcja.new{|x| x**2 + 2*x}.pole(0, 20)}"
puts "#{Funkcja.new{|x| x**2 + 2*x}.poch(1.2)}"
