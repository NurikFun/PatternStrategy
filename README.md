# PatternStrategy

![Overall picture](https://i.stack.imgur.com/05vlo.png)

1.1 Инкапсулируйте то, что изменяется
1.2 Отдавайте предпочтение композиции перед наследованием
1.3 Программируйте на уровне интерфейсов, а не реализации
1.4 Стратегия - определяет семейство алгоритмов, инкапсулирует и обеспечивает их взаимозаменяемость. Паттерн позволяет модифицировать алгоритмы независимо от их использования на стороне клиента.


Когда использовать стратегию?
2.1 Когда есть несколько родственных классов, которые отличаются поведением. Можно задать один основной класс, а разные варианты поведения вынести в отдельные классы и при необходимости их применять

2.2 Когда необходимо обеспечить выбор из нескольких вариантов алгоритмов, которые можно легко менять в зависимости от условий

2.3 Когда необходимо менять поведение объектов на стадии выполнения программы

2.4 Когда класс, применяющий определенную функциональность, ничего не должен знать о ее реализации
