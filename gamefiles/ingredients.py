class Ingredient:
    def __init__(self, name, image, nutritional_value) -> None:
        self.name = name
        self.image = image
        self.nutritional_value = nutritional_value

class Food:
    def __init__(self) -> None:
        pass

class Egg(Ingredient):
    def __init__(self, name = "Egg", image = "", nutritional_value = 10) -> None:
        super().__init__(name, image, nutritional_value)


ingredient1 = Egg()