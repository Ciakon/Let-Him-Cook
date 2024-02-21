from gamefiles.setup import *

def level(levelnumber):

    if levelnumber == 1:
        level_1()

def level_1():
    screen.fill((255, 255, 255))

    pygame.draw.circle(screen, (0, 0, 255), (250, 250), 75)
    pygame.display.flip()