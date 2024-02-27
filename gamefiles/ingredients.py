import pygame

class Ingredient:
    def __init__(self, name, imagepath, nutritional_value) -> None:
        self.name = name
        self.image = pygame.image.load(imagepath)
        self.nutritional_value = nutritional_value

class Food:
    def __init__(self) -> None:
        pass

class Egg(Ingredient):
    def __init__(self, name = "Egg", imagepath = "assets/egg.png", nutritional_value = 10) -> None:
        super().__init__(name, imagepath, nutritional_value)


# create food objects
egg = Egg()