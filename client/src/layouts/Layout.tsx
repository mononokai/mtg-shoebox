import Header from '../components/Header'

type LayoutProps = {
  children: React.ReactNode;
}

export default function Layout({ children }: LayoutProps) {
  return (
    <div>
      <Header />

      <main>{children}</main>
    </div>
  )
}