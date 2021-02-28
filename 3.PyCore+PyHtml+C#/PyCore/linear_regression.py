import numpy as np

class LinearRegression():
    def __init__(self, alpha=0.1, a=0, b=0, n_iterations=100):
        self.alpha = alpha
        self.a = a
        self.b = b
        self.n_iterations = 5
        self.n = 0
        self.x = []
        self.y = []

    def model(self):
        return self.a*self.x + self.b

    def cost(self):
        return 0.5/self.n * (np.square(self.y-self.a*self.x-self.b)).sum()

    def optimize(self):
        y_hat = self.model()
        da = (1.0/self.n) * ((y_hat-self.y)*self.x).sum()
        db = (1.0/self.n) * ((y_hat-self.y).sum())
        self.a = self.a - self.alpha*da
        self.b = self.b - self.alpha*db

    def fit(self, x, y):
        self.x = x
        self.y = y
        self.n = len(x)

        for i in range(self.n_iterations):
            self.optimize()