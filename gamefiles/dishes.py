from ingredients import egg

class Dish:
    def __init__(self, name, image, madeOn, ingredients=[]):
        self.name = name
        self.image = image
        self.madeOn = madeOn
        self.components = ingredients
        self.nutritional_value = 10
        for i in ingredients:
            self.nutritional_value += i.nutritional_value
        

class ScrambleEgg(Dish):
    def __init__(self, name, image, madeOn, ingredients=[]):
        super().__init__(name, image, madeOn, ingredients)



a = Dish("egg", 1, "pan", [egg])
print(a.nutritional_value)
b = egg
print(b.nutritional_value)