class Jawna
  def initialize(napis)
    @napis = napis
  end
  def to_s
    return @napis
  end
  def zaszyfruj(klucz)
    nowynapis = ""
    @napis.each_char do |chr|
     nchar = klucz[chr]
     if nchar == nil
       nowynapis << chr
     else
       nowynapis << nchar
     end
   end
     return Zaszyfrowane.new(nowynapis)
   end
end


class Zaszyfrowane
  def initialize(napis)
    @napis = napis
  end
  def to_s
    return @napis
  end
  def odszyfruj(stary_klucz)
    klucz = stary_klucz.invert
    return Jawna.new(@napis).zaszyfruj(klucz)
  end
end

jaw = Jawna.new("ruby")
zasz = jaw.zaszyfruj({"a"=>"b","r"=>"y", "b"=>"r", "y"=>"u", "u"=>"a"})
puts "#{jaw}"
puts "#{zasz}"
puts "#{zasz.odszyfruj({"a"=>"b","r"=>"y", "b"=>"r", "y"=>"u", "u"=>"a"})}"
