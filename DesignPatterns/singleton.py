class Singleton:
    _instance = None

    def __new__(cls, *args, **kwargs):
        if not cls._instance:
            cls._instance = super(Singleton, cls).__new__(cls, *args, **kwargs)
        return cls._instance

    def __init__(self, value):
        if not hasattr(self, 'initialized'):
            self.value = value
            self.initialized = True


if __name__ == "__main__":
    s1 = Singleton("First Instance")
    print(s1.value)  # Output: First Instance

    s2 = Singleton("Second Instance")
    print(s2.value)  # Output: First Instance

    print(s1 is s2)  # Output: True