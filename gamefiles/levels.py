import gamefiles.setup as setup
from gamefiles.ingredients import egg
from gamefiles.setup import window_height, window_width

import pygame

is_level_setup = False

def play_level(levelnumber):
    global is_level_setup

    if not is_level_setup:
        is_level_setup = True
        level_setup()

    if levelnumber == 1:
        level_1()

def level_setup():
    pass


def level_1():
    setup.screen.fill("gray")

    # draw cooking pan
    pygame.draw.circle(setup.screen, "black", (window_width / 2, window_height / 2), 75)

    # Draw egg
    draw_image(egg.image, window_width / 2, window_height / 2)
    

    pygame.display.flip()

def draw_image(image, x, y):
    rect = image.get_rect()
    width = rect[2]
    height = rect[3]

    x -= width / 2
    y -= height / 2
    
    setup.screen.blit(image, (x, y))