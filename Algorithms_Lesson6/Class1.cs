using System;
using System.Collections;
using System.Collections.Generic;

// Шитов Евгений

namespace Algorithms_Lesson6
{
    public class BinaryTree<T> : ICollection<T>
    {
        protected class Node<TValue>
        {
            public TValue Value { get; }
            public Node<TValue> Left { get; set; }
            public Node<TValue> Right { get; set; }

            public Node(TValue value)
            {
                Value = value;
            }
        }

        private Node<T> _root;
        private readonly IComparer<T> _comparer;

        public BinaryTree() : this(Comparer<T>.Default)
        {
        }

        private BinaryTree(IComparer<T> defComparer)
        {
            if (defComparer == null)
                throw new ArgumentNullException("Default comparer is null");
            _comparer = defComparer;
        }

        public T MinVal
        {
            get
            {
                if (_root == null)
                {
                    throw new InvalidOperationException("Tree is empty");
                }

                var current = _root;
                while (current.Left != null)
                {
                    current = current.Left;
                }

                return current.Value;
            }
        }

        public T MaxVal
        {
            get
            {
                if (_root == null)
                {
                    throw new InvalidOperationException("Tree is empty");
                }

                var current = _root;
                while (current.Right != null)
                {
                    current = current.Right;
                }

                return current.Value;
            }
        }

        public IEnumerable<T> Inorder()
        {
            if (_root == null)
            {
                yield break;
            }

            var stack = new Stack<Node<T>>();
            var node = _root;

            while (stack.Count > 0 || node != null)
            {
                if (node == null)
                {
                    node = stack.Pop();
                    yield return node.Value;
                    node = node.Right;
                }

                else
                {
                    stack.Push(node);
                    node = node.Left;
                }
            }
        }

        public IEnumerable<T> Preorder()
        {
            if (_root == null)
            {
                yield break;
            }

            var stack = new Stack<Node<T>>();
            stack.Push(_root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                yield return node.Value;
                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }

        public IEnumerable<T> Postorder()
        {
            if (_root == null)
            {
                yield break;
            }

            var stack = new Stack<Node<T>>();
            var node = _root;

            while (stack.Count > 0 || node != null)
            {
                if (node == null)
                {
                    node = stack.Pop();
                    if (stack.Count > 0 && node.Right == stack.Peek())
                    {
                        stack.Pop();
                        stack.Push(node);
                        node = node.Right;
                    }

                    else
                    {
                        yield return node.Value;
                        node = null;
                    }
                }

                else
                {
                    if (node.Right != null)
                        stack.Push(node.Right);
                    stack.Push(node);
                    node = node.Left;
                }
            }
        }

        public IEnumerable<T> Levelorder()
        {
            if (_root == null)
            {
                yield break;
            }

            var queue = new Queue<Node<T>>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                yield return node.Value;

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        #region ICollection<T> Members

        public int Count { get; private set; }

        public virtual void Add(T item)
        {
            var node = new Node<T>(item);

            if (_root == null)
            {
                _root = node;
            }

            else
            {
                Node<T> current = _root, parent = null;

                while (current != null)
                {
                    parent = current;
                    current = _comparer.Compare(item, current.Value) < 0 ? current.Left : current.Right;
                }

                if (parent != null && _comparer.Compare(item, parent.Value) < 0)
                {
                    parent.Left = node;
                }

                else if (parent != null)
                {
                    parent.Right = node;
                }
            }

            ++Count;
        }

        public virtual bool Remove(T item)
        {
            if (_root == null)
            {
                return false;
            }

            Node<T> current = _root, parent = null;

            int result;

            do
            {
                result = _comparer.Compare(item, current.Value);

                if (result < 0)
                {
                    parent = current;
                    current = current.Left;
                }

                else if (result > 0)
                {
                    parent = current;
                    current = current.Right;
                }

                if (current == null)
                {
                    return false;
                }
            } while (result != 0);

            if (current.Right == null)
            {
                if (current == _root)
                {
                    _root = current.Left;
                }

                else
                {
                    if (parent != null)
                    {
                        result = _comparer.Compare(current.Value, parent.Value);
                        if (result < 0)
                        {
                            parent.Left = current.Left;
                        }

                        else
                        {
                            parent.Right = current.Left;
                        }
                    }
                }
            }

            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (current == _root)
                {
                    _root = current.Right;
                }

                else
                {
                    if (parent != null)
                    {
                        result = _comparer.Compare(current.Value, parent.Value);

                        if (result < 0)
                        {
                            parent.Left = current.Right;
                        }

                        else
                        {
                            parent.Right = current.Right;
                        }
                    }
                }
            }

            else
            {
                Node<T> min = current.Right.Left, prev = current.Right;
                while (min.Left != null)
                {
                    prev = min;
                    min = min.Left;
                }

                prev.Left = min.Right;
                min.Left = current.Left;
                min.Right = current.Right;

                if (current == _root)
                {
                    _root = min;
                }

                else
                {
                    if (parent != null)
                    {
                        result = _comparer.Compare(current.Value, parent.Value);
                        if (result < 0)
                        {
                            parent.Left = min;
                        }

                        else
                            parent.Right = min;
                    }
                }
            }

            --Count;
            return true;
        }

        public void Clear()
        {
            _root = null;
            Count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (var value in this)
            {
                array[arrayIndex++] = value;
            }
        }

        public virtual bool IsReadOnly => false;

        public bool Contains(T item)
        {
            var current = _root;
            while (current != null)
            {
                var result = _comparer.Compare(item, current.Value);
                if (result == 0)
                    return true;
                current = result < 0 ? current.Left : current.Right;
            }

            return false;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Inorder().GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}