import { render, screen } from '@testing-library/react';
import App from './App';

test('renders blog details heading', () => {
  render(<App />);
  const headingElement = screen.getByText(/blog details component/i);
  expect(headingElement).toBeInTheDocument();
});
