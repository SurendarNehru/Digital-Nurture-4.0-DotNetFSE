import { render, screen } from '@testing-library/react';
import App from './App';

test('renders Student Score Calculator heading', () => {
  render(<App />);
  const headingElement = screen.getByText(/student score calculator/i);
  expect(headingElement).toBeInTheDocument();
});
