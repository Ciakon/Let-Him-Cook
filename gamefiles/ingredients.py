import pygame

class Ingredient:
    def __init__(self, name, imagepath, nutritional_value) -> None:
        self.name = name
        self.image = pygame.image.load(imagepath)
        self.nutritional_value = nutritional_value
        self.position = [0, 0]
        self.is_moving = False
        self.size = self.image.get_rect()[2:4]

    def draw(self, screen):
        rect = self.image.get_rect()
        width = rect[2]
        height = rect[3]

        x = self.position[0] - width / 2
        y = self.position[1] - height / 2
        
        screen.blit(self.image, (x, y))

class Food:
    def __init__(self) -> None:
        pass

class Egg(Ingredient):
    def __init__(self, name = "Egg", imagepath = "assets/egg.png", nutritional_value = 10) -> None:
        super().__init__(name, imagepath, nutritional_value)


# create food objects
egg = Egg()