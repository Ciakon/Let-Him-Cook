import ingredients

class Dish:
    def __init__(self, name, image, nutritional_value, madeOn, ingredients=[]):
        self.name = name
        self.image = image
        self.madeOn = madeOn
        self._components = ingredients
        self._nutritional_value = nutritional_value

class ScrambleEgg(Dish):
    def __init__(self, name = "ScrambleEgg", image = None, nutritional_value = 10, madeOn = ["Pan"], ingredients=["Egg"]):
        super().__init__(name, image, nutritional_value, madeOn, ingredients)
