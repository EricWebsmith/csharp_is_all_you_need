import numpy as np
import sys
import matplotlib.pyplot as plt
# start import your python project
sys.path.append(r"D:\projects\PySharp\2.PyCore+PyMedia+C#\PyCore")
from linear_regression import LinearRegression

def main():
    x = [13854,12213,11009,10655,9503]
    x = np.reshape(x,newshape=(5,1)) / 10000.0
    y =  [21332, 20162, 19138, 18621, 18016]
    y = np.reshape(y,newshape=(5,1)) / 10000.0

    params = []
    model = LinearRegression(alpha=0.2, n_iterations=5)
    model.x = x
    model.y = y
    model.n = 5

    for i in range(10):
        model.optimize()
        y_hat = model.model()
        params.append((model.a, model.b))
        plt.scatter(x,y)
        plt.plot(x, y_hat)
        plt.savefig(f"{i+1}.png")
        plt.cla()

    for a, b in params:
        print(a, b)

if __name__ == "__main__":
    main()