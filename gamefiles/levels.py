import gamefiles.setup as setup
from gamefiles.ingredients import egg
from gamefiles.setup import window_height, window_width, screen

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
    #egg.position = [window_width / 2, window_height / 2]
    move_object(egg)

    egg.draw(screen)
    

    pygame.display.flip()

def move_object(obj):
    if obj.is_moving:
        obj.position = pygame.mouse.get_pos()

    if setup.is_mouse_clicked:
        mouse_pos = pygame.mouse.get_pos()
        
        x1 = obj.position[0] - obj.size[0] / 2
        x2 = obj.position[0] + obj.size[0] / 2
        y1 = obj.position[1] - obj.size[1] / 2
        y2 = obj.position[1] + obj.size[1] / 2

        if obj.is_moving:
            obj.is_moving = False

        elif mouse_pos[0] > x1 and mouse_pos[0] < x2 and mouse_pos[1] > y1 and mouse_pos[1] < y2:
            if not obj.is_moving:
                obj.is_moving = True    