import pygame

running = None
screen = None
levelnumber = None


def setup():
    global screen, running, levelnumber

    running = True
    levelnumber = 1

    window_width = 1280
    window_height = 720

    pygame.init()

    screen = pygame.display.set_mode([window_width, window_height])