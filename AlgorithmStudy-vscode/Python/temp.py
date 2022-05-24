import numpy as np


def convolution2d(image, kernel, stride=1, padding=0):
    """
    from https://stackoverflow.com/a/65269944
    """
    image = np.pad(image, [(padding, padding), (padding, padding)], mode="constant", constant_values=0)

    kernel_height, kernel_width = kernel.shape
    padded_height, padded_width = image.shape

    output_height = (padded_height - kernel_height) // stride + 1
    output_width = (padded_width - kernel_width) // stride + 1

    new_image = np.zeros((output_height, output_width)).astype(np.float32)

    for y in range(0, output_height):
        for x in range(0, output_width):
            new_image[y][x] = np.sum(image[y * stride : y * stride + kernel_height, x * stride : x * stride + kernel_width] * kernel).astype(np.float32)
    return new_image


input = np.array([[5, 4, 0, 3], [6, 2, 1, 8], [7, 9, 4, 2]])
kernel = np.array([[1, 2, 1], [2, 4, 2], [1, 2, 1]]) * (1 / 16)
output = convolution2d(input, kernel, padding=1)

print("input:\n", input)
print("kernel:\n", kernel)
print("output:\n", output)
